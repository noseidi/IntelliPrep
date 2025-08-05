import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Question } from '../../core/services/models/question.model';

@Injectable({
  providedIn: 'root'
})
export class QuestionService {
  private baseUrl = 'https://localhost:5001/api/questions'; // یا آدرس backend خودت

  constructor(private http: HttpClient) {}

  getQuestions(): Observable<Question[]> {
    return this.http.get<Question[]>(this.baseUrl);
  }

  // سایر متدها مثل post, put, delete
}