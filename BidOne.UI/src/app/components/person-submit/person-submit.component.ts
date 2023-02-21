import { Component } from '@angular/core';
import { Person } from 'src/app/models/person.model';
import { PersonService } from 'src/app/services/person.service';

@Component({
  selector: 'app-person-submit',
  templateUrl: './person-submit.component.html',
  styleUrls: ['./person-submit.component.css']
})
export class PersonSubmitComponent {
  person: Person = { 
    firstName:'', 
    lastName:'' 
  };

  isError: boolean = false;
  message: string = '';

  constructor(private personService: PersonService){}

  public submitPerson() {
    this.personService.submitPerson(this.person).subscribe({
        next: (response)=> { 
          this.isError = false;
          this.message = 'Submitting this person data was successful';
          console.log(response); 
        },
        error: (response)=> { 
          this.isError = true;
          this.message = 'Both fields are required';
          console.log(response); 
        }
    });
  }
}
