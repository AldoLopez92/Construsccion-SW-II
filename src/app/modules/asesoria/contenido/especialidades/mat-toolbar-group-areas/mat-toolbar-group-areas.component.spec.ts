import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MatToolbarGroupAreasComponent } from './mat-toolbar-group-areas.component';

describe('MatToolbarGroupAreasComponent', () => {
  let component: MatToolbarGroupAreasComponent;
  let fixture: ComponentFixture<MatToolbarGroupAreasComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MatToolbarGroupAreasComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MatToolbarGroupAreasComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
