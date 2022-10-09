import { Component } from '@angular/core';
import { PremiumService } from './premiumcalculator.service';

@Component({
  selector: 'app-premiumcalculator',
  templateUrl: './premiumcalculator.component.html',
  styleUrls: ['./premiumcalculator.component.css']
})

export class PremiumcalculatorComponent {
  public premium = "";

  constructor(private premiumService: PremiumService)
  { } 

  occupations = ['Cleaner', 'Doctor', 'Author', 'Farmer',
    'Mechanic', 'Florist'];

  public onSubmit(data: any){
     this.premiumService.CalculatePremium(data).subscribe(
      result => { this.premium = result + " AUD";  },
      () => {
        this.premium = "Could not be calculated due to an unexpected Error";
      }) 
    }

  public onChange($event: any, data: any) {
    if (data.name == null || data.name == '')
      alert("Name should be filled");
    else if (data.age == null || data.age == '')
      alert("Age should be filled");
    else if (data.dob == null || data.dob == '')
      alert("Date of Birth should be filled");
    else if (data.sum == null || data.sum == '')
      alert("Death - Sum Insured should be filled");
    else {
      this.premiumService.CalculatePremium(data).subscribe(
       result => { this.premium = result + " AUD";  },
       () => {
         this.premium = "Could not be calculated due to an unexpected Error";
       }) 
     }
  }
}