import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { IBaseService } from '../utility/base';
import { OperationResult } from '../utility/operation-result';
import { Pagination, PaginationResult } from '../utility/pagination';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from '../../../environments/environment';


const API_URL = environment.apiUrl


@Injectable({
  providedIn: 'root'
})
export class BaseService<T> implements IBaseService<T> {

  constructor(
    public http: HttpClient,
    private entity: string,
  ) { }



  add(entity: T): Promise<OperationResult> {
    return this.http.post<OperationResult>(`${API_URL}/${this.entity}/Add${this.entity}`, entity).toPromise();
  }
  update(entity: T): Promise<OperationResult> {
    return this.http.put<OperationResult>(`${API_URL}/${this.entity}/Update${this.entity}`, entity).toPromise();
  }
  remove(id: any): Promise<T> {
    return this.http.delete<T>(`${API_URL}/${this.entity}/Delete${this.entity}`, { params: { key: id } }).toPromise();
  }

  getAll(): Observable<T[]> {
    return this.http.get<T[]>(`${API_URL}${this.entity}/Get${this.entity}`);
  }

  search(keyword: string, pagination: Pagination): Observable<PaginationResult<T>> {
    let params = new HttpParams();
    if (pagination.currentPage !== null && pagination.pageSize !== null) {
      params = params.append('pageNumber', pagination.currentPage.toString());
      params = params.append('pageSize', pagination.pageSize.toString());
    }
    return this.http.post<PaginationResult<T>>(`${API_URL}/${this.entity}/Search${this.entity}?keyword=${keyword}`, {}, { params });
  }
}
