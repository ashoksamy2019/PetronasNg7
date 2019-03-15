import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from "@angular/forms";
import { HttpClientModule } from "@angular/common/http";
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
 
import { ToastrModule } from 'ngx-toastr';

import { AppComponent } from './app.component';
import { ResourceDetailsComponent } from './resource-details/resource-details.component';
import { ResourceDetailComponent } from './resource-details/resource-detail/resource-detail.component';
import { ResourceDetailListComponent } from './resource-details/resource-detail-list/resource-detail-list.component';
import { ResourceDetailService } from './shared/resource-detail.service';

@NgModule({
  declarations: [
    AppComponent,
    ResourceDetailsComponent,
    ResourceDetailComponent,
    ResourceDetailListComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpClientModule,
    BrowserAnimationsModule,
    ToastrModule.forRoot()
  ],
  providers: [ResourceDetailService],
  bootstrap: [AppComponent]
})
export class AppModule { }
