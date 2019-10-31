import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MitesisComponent } from './mitesis.component';

describe('MitesisComponent', () => {
  let component: MitesisComponent;
  let fixture: ComponentFixture<MitesisComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MitesisComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MitesisComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
