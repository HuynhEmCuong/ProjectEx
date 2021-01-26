import { Observable } from "rxjs";
import { OperationResult } from "./operation-result";
import { Pagination, PaginationResult } from "./pagination";

export interface IBaseService<T> {
    add(entity: T): Promise<OperationResult>;
    update(entity: T): Promise<OperationResult>;
    remove(id): Promise<T>;

    
    getAll(): Observable<T[]>;
    search(keyword: string, pagination: Pagination): Observable<PaginationResult<T>>

}