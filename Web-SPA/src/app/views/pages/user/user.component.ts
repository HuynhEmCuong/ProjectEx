import { Component, OnInit } from '@angular/core';
import { UserService } from '../../../core/services/user.service';
declare var jQuery: any;
@Component({
  selector: 'app-user',
  templateUrl: './user.component.html',
  styleUrls: ['./user.component.css']
})
export class UserComponent implements OnInit {

  constructor(private _userService: UserService) { }

  ngOnInit(): void {


  }


  async uploadFile(event) {
    const file = event.target.files[0];
    const data = await this._userService.uploadFile(file).then();
    alert(data.message);

  }

}
