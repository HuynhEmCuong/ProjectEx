import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Building } from '../models/building';
import { BaseService } from './base.service';

@Injectable({
  providedIn: 'root'
})
export class BuildingService extends BaseService<Building> {

constructor( public _http:HttpClient) {
  super(_http,"Building")
 }

}
