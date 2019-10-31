import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MislogrosComponent } from './mislogros.component';

describe('MislogrosComponent', () => {
  let component: MislogrosComponent;
  let fixture: ComponentFixture<MislogrosComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MislogrosComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MislogrosComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
