import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { TestsRoutingModule } from './tests-routing.module';
import { TestsComponent } from './tests.component';
import { TestListComponent } from './test-list/test-list.component';
import { TestFormComponent } from './test-form/test-form.component';


@NgModule({
  declarations: [
    TestsComponent,
    TestListComponent,
    TestFormComponent
  ],
  imports: [
    CommonModule,
    TestsRoutingModule
  ]
})
export class TestsModule { }
