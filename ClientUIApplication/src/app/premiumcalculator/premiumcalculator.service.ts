import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse } from "@angular/common/http";

@Injectable({
  providedIn: 'root'
})

export class PremiumService {
  
  readonly apiUrl = 'https://localhost:7262';

  constructor(private http: HttpClient) { }

  CalculatePremium(data: any)
  {
    return this.http.get(this.apiUrl + '/premiumCalculator' + "?amount=" + data.sum + "&occupation=" + data.occupation + "&age=" + data.age);
  }
}
