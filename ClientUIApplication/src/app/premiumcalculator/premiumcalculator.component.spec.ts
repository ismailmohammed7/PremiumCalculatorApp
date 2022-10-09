import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PremiumcalculatorComponent } from './premiumcalculator.component';

describe('PremiumcalculatorComponent', () => {
  let component: PremiumcalculatorComponent;
  let fixture: ComponentFixture<PremiumcalculatorComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PremiumcalculatorComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(PremiumcalculatorComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
