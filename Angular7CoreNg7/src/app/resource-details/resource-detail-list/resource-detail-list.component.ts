import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { ResourceDetailService } from 'src/app/shared/resource-detail.service';
import { ResourceDetail } from 'src/app/shared/resource-detail.model';

@Component({
  selector: 'app-resource-detail-list',
  templateUrl: './resource-detail-list.component.html',
  styles: []
})
export class ResourceDetailListComponent implements OnInit {

  constructor(private service: ResourceDetailService,
    private toastr: ToastrService) { }

  ngOnInit() {
    this.service.refreshList();
  }
  populateForm(rd: ResourceDetail) {
    this.service.formData = Object.assign({}, rd);
  }

  onDelete(ResID) {
    if (confirm('Are you sure to delete this record ?')) {
      this.service.deleteResourceDetail(ResID)
        .subscribe(res => {
          debugger;
          this.service.refreshList();
          this.toastr.warning('Deleted successfully', 'Resrouce Detail Register');
        },
          err => {
            debugger;
            console.log(err);
          })
    }
  }
}
