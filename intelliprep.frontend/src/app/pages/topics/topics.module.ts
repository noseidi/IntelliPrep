import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { TopicsRoutingModule } from './topics-routing.module';
import { TopicsComponent } from './topics.component';
import { TopicListComponent } from './topic-list/topic-list.component';
import { TopicFormComponent } from './topic-form/topic-form.component';


@NgModule({
  declarations: [
    TopicsComponent,
    TopicListComponent,
    TopicFormComponent
  ],
  imports: [
    CommonModule,
    TopicsRoutingModule
  ]
})
export class TopicsModule { }
