import { Component, Input, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ModalDirective } from 'ngx-bootstrap/modal';
import { PDC } from '../../../../core/models/pdc';
import { PdcService } from '../../../../core/services/pdc.service';

@Component({
  selector: 'app-pdc-edit-modal',
  templateUrl: './pdc-edit-modal.component.html',
  styleUrls: ['./pdc-edit-modal.component.scss']
})
export class PdcEditModalComponent implements OnInit {
  @ViewChild('editModal', { static: false }) childModal: ModalDirective;
  formData: FormGroup;
  checkAdd: boolean = true;
  @Input() set item(item: PDC) {
    this.initForm();
    if (item) {
      this.checkAdd = false;
      this.formData.patchValue(item);
    }
  };

  constructor(private fb: FormBuilder, private _pdcService: PdcService) { }

  ngOnInit() {
  }

  showModal() {
    this.childModal.show();
  }


  hideModal() {
    this.childModal.hide();
  }

  initForm() {
    this.formData = this.fb.group({
      pdcid:0,
      pdcName: ["",
        Validators.compose([
          Validators.required
        ])
      ],
      pdcCode: [
        "",
        Validators.compose([
          Validators.required,
          Validators.maxLength(4)
        ])
      ],
      visible: true,
    });
  }

  async addOrEdit() {
    let data;
    if (this.checkAdd) 
      data = await this._pdcService.add(this.formData.value).then();
    else 
      data = await this._pdcService.update(this.formData.value).then()
    
    if (data.success) {
      alert("Ok")
    }
    this.hideModal();
    this.formData.reset()
  }

}
