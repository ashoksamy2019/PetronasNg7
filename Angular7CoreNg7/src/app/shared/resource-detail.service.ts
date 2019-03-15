import { Injectable } from '@angular/core';
import { ResourceDetail } from './resource-detail.model';
import { HttpClient } from "@angular/common/http";

@Injectable({
  providedIn: 'root'
})
export class ResourceDetailService {
  formData:ResourceDetail;
  readonly rootURL = 'http://localhost:50749/api';
  list : ResourceDetail[];

   constructor(private http: HttpClient) { }

  postResourceDetail() { 
    return this.http.post(this.rootURL + '/ResourceDetails', this.formData);
  }
  putResourceDetail() {
    return this.http.put(this.rootURL + '/ResourceDetails/'+ this.formData.ResID, this.formData);
  }
  deleteResourceDetail(id) {
    return this.http.delete(this.rootURL + '/ResourceDetails/'+ id);
  }
  refreshList(){
    this.http.get(this.rootURL + '/ResourceDetail')
    .toPromise()
    .then(res => this.list = res as ResourceDetail[]);
  }
}
