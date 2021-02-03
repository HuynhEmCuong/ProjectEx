import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from '../../../environments/environment';
import { OperationResult } from '../utility/operation-result';

const API_URL = environment.apiUrl

@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor(private http: HttpClient) { }

  uploadFile(file): Promise<OperationResult> {
    return this.http.post<OperationResult>(`${API_URL}/User/UploadFile`, file).toPromise();
  }
}
