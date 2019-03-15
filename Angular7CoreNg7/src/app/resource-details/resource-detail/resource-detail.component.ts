import { Component, OnInit } from '@angular/core';
import { ResourceDetailService } from './../../shared/resource-detail.service';
import { NgForm } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-resource-detail',
  templateUrl: './resource-detail.component.html',
  styles: []
})
export class ResourceDetailComponent implements OnInit {

  constructor(private service:ResourceDetailService,
    private toastr:ToastrService) { }

  ngOnInit() {
    this.resetForm();
  }

  resetForm(form?: NgForm) {
    if (form != null)
      form.form.reset();
    this.service.formData = {
      ResID: 0,
      ResouceName: '',
      ResURL: '',
      CreatedDate: ''
    }
  }

  
  onSubmit(form: NgForm) {
    if (this.service.formData.ResID == 0)
      this.insertRecord(form);
    else
      this.updateRecord(form);
  }

  insertRecord(form: NgForm) {
    this.service.postResourceDetail().subscribe(
      res => {
        debugger;
        this.resetForm(form);
        this.toastr.info('Submitted successfully', 'Resource Detail Register');
        this.service.refreshList();
      },
      err => {
        debugger;
        console.log(err);
      }
    )
  }
  updateRecord(form: NgForm) {
    this.service.putResourceDetail().subscribe(
      res => {
        this.resetForm(form);
        this.toastr.info('Submitted successfully', 'Resource Detail Register');
        this.service.refreshList();
      },
      err => {
        console.log(err);
      }
    )
  }


}
