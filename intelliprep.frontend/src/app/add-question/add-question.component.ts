import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
@Component({
    selector: 'app-add-question',
  standalone :true ,
  imports:[FormsModule],
  templateUrl: './add-question.component.html',
  styleUrls: ['./add-question.component.scss']
})
export class AddQuestionComponent {
  questionText: string = '';
  topicId: number | null = null;
  difficulty: number | null = null;
  apiUrl = 'https://localhost:5001/api/questions';

  constructor(private http: HttpClient) {}

  addQuestion() {
    if (!this.questionText || !this.topicId || !this.difficulty) {
      alert('لطفا همه فیلدها را پر کنید');
      return;
    }

    const newQuestion = {
      text: this.questionText,
      topicId: this.topicId,
      difficulty: this.difficulty
    };

    this.http.post(this.apiUrl, newQuestion).subscribe({
      next: (res) => {
        alert('سؤال با موفقیت ثبت شد!');
        this.questionText = '';
        this.topicId = null;
        this.difficulty = null;
      },
      error: (err) => {
        console.error(err);
        alert('خطا در ثبت سؤال');
      }
    });
  }
}