import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { PDC } from '../models/pdc';
import { BaseService } from './base.service';

@Injectable({
  providedIn: 'root'
})
export class PdcService extends BaseService<PDC> {

  constructor(public http: HttpClient) {
    super(http, "PDC")
  }

}
