/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { DumpValueComponent } from './dump-value.component';

describe('DumpValueComponent', () => {
  let component: DumpValueComponent;
  let fixture: ComponentFixture<DumpValueComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DumpValueComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DumpValueComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
