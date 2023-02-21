import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PersonSubmitComponent } from './person-submit.component';

describe('PersonSubmitComponent', () => {
  let component: PersonSubmitComponent;
  let fixture: ComponentFixture<PersonSubmitComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PersonSubmitComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(PersonSubmitComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
