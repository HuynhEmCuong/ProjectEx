import { Component, Input, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ModalDirective } from 'ngx-bootstrap/modal';
import { PDC } from '../../../../core/models/pdc';

@Component({
  selector: 'app-pdc-edit-modal',
  templateUrl: './pdc-edit-modal.component.html',
  styleUrls: ['./pdc-edit-modal.component.scss']
})
export class PdcEditModalComponent implements OnInit {
  @ViewChild('editModal', { static: false }) childModal: ModalDirective;
  formData: FormGroup;

  @Input() set item(item: PDC) {
    this.initForm();
    if (item)
      this.formData.patchValue(item);
  };

  constructor(private fb: FormBuilder) { }

  ngOnInit() {
  }

  showModal() {
    this.childModal.show();
  }


  hideModal() {
    this.childModal.show();
  }

  initForm() {
    this.formData = this.fb.group({
      pdcName: ["",
        Validators.compose([
          Validators.required
        ])
      ],
      pdcCode: [
        "",
        Validators.compose([
          Validators.required,
          Validators.maxLength(2)
        ])
      ],
      visible: true
    });
  }

  addOrEdit(){
debugger
  }

}
