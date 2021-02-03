import { Component, OnInit } from '@angular/core';
declare var jQuery: any;
@Component({
  selector: 'app-user',
  templateUrl: './user.component.html',
  styleUrls: ['./user.component.css']
})
export class UserComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {


  }


  uploadFile(event) {
    const file = event.target.files[0];
  }

}
