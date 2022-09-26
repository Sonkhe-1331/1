/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { CentreComponent } from './centre.component';

describe('CentreComponent', () => {
  let component: CentreComponent;
  let fixture: ComponentFixture<CentreComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CentreComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CentreComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
