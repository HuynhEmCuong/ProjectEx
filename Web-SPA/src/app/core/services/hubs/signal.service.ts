import { Injectable } from '@angular/core';
import * as signalR from '@aspnet/signalr';
import { BehaviorSubject, Subject } from 'rxjs';
import { environment } from '../../../../environments/environment';
import { PDC } from '../../models/pdc';

const hubs = environment.hubs;

@Injectable({
  providedIn: 'root'
})
export class SignalService {
  private hubConnection: signalR.HubConnection;
  messageList = new BehaviorSubject<string[]>([]);
  dataPDC = new Subject<PDC[]>();

  constructor() {
    this.createHubConnection();
  }


  createHubConnection() {
    this.hubConnection = new signalR.HubConnectionBuilder().withUrl(hubs, {
      skipNegotiation: true,
      transport: signalR.HttpTransportType.WebSockets
    }).build();

    //Start conections hubs
    this.hubConnection
      .start()
      .then(() => { console.log('Connection started'); })
      .catch(error => { console.log('Error connection ------  ' + error); });


    this.hubConnection.on("PDCData", (data) => {
      this.dataPDC.next(data);
    })

    this.hubConnection.on("NotifyLoad", (message) => {
      this.messageList.next(message);
    })
  }


  async sendMessage(message) {
    return this.hubConnection.invoke("NotifyLoad", message).catch(error => console.log(error));;
  }
}
