import { Component, OnInit } from '@angular/core';
import { QuestionService } from '../../../core/services/question.service';
import { Question } from '../../../core/services/models/question.model';

@Component({
   standalone: false,
  selector: 'app-question-list',
  templateUrl: './question-list.component.html',
  styleUrls: ['./question-list.component.scss']
})
export class QuestionListComponent implements OnInit {
  questions: Question[] = [];

  constructor(private questionService: QuestionService) {}

  ngOnInit(): void {
    this.questionService.getQuestions().subscribe((data: Question[]) => {
      this.questions = data;
    });
  }
}