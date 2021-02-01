import { Component, OnInit, ViewChild } from '@angular/core';
import { PDC } from '../../../core/models/pdc';
import { PdcService } from '../../../core/services/pdc.service';
import { PdcEditModalComponent } from './pdc-edit-modal/pdc-edit-modal.component';

@Component({
  selector: 'app-pdc',
  templateUrl: './pdc.component.html',
  styleUrls: ['./pdc.component.scss']
})
export class PdcComponent implements OnInit {
  @ViewChild("modal") modalEdit: PdcEditModalComponent
  pdcList: PDC[];
  itemPDC: PDC;
  constructor(private _pdcService: PdcService) { }

  ngOnInit(): void {
    this.loadData();
  }

  loadData() {
    this._pdcService.getAll().subscribe(res => {
      this.pdcList = res;
      console.log(res);
    })
  }

  editItem(item: PDC) {
    this.modalEdit.showModal();
    this.itemPDC = item;
  }

}
