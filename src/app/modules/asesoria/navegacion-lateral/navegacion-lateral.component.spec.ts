import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { NavegacionLateralComponent } from './navegacion-lateral.component';

describe('NavegacionLateralComponent', () => {
  let component: NavegacionLateralComponent;
  let fixture: ComponentFixture<NavegacionLateralComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ NavegacionLateralComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(NavegacionLateralComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
