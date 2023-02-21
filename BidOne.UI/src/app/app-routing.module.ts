import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { PersonSubmitComponent } from './components/person-submit/person-submit.component';

const routes: Routes = [ {path: '',  component: PersonSubmitComponent}];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
