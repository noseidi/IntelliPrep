import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { QuestionsRoutingModule } from './questions-routing.module';
import { QuestionsComponent } from './questions.component';
import { QuestionFormComponent } from './question-form/question-form.component';
import { QuestionListComponent } from './question-list/question-list.component';
import { RouterModule } from '@angular/router';
@NgModule({
  declarations: [
    QuestionListComponent,
    QuestionFormComponent
  ],
  imports: [
    CommonModule,
    RouterModule
  ]
})
export class QuestionsModule { }
