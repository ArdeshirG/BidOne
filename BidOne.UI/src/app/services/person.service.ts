import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment.development';
import { HttpClient } from '@angular/common/http';
import { Person } from '../models/person.model';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class PersonService {

  baseApiUrl: string  = environment.baseApiUrl;

  constructor(private httpClient: HttpClient) { }

  submitPerson(person: Person): Observable<any> {
    return this.httpClient.post<Person>(this.baseApiUrl + 'api/person', person);
  }
}
