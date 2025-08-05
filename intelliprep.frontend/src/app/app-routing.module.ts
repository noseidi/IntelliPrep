import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [{ path: 'questions', loadChildren: () => import('./pages/questions/questions.module').then(m => m.QuestionsModule) }, { path: 'topics', loadChildren: () => import('./pages/topics/topics.module').then(m => m.TopicsModule) }, { path: 'tests', loadChildren: () => import('./pages/tests/tests.module').then(m => m.TestsModule) }];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
