import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

export interface Question {
  id: number;
  text: string;
  topicId: number;
}

@Injectable({
  providedIn: 'root',
})
export class QuestionService {
  private apiUrl = 'https://localhost:5001/api/questions'; // آدرس بک‌اند خودتو بذار

  constructor(private http: HttpClient) {}

  getQuestions(): Observable<Question[]> {
    return this.http.get<Question[]>(this.apiUrl);
  }
}