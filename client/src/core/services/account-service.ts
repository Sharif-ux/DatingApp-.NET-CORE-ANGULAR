import { HttpClient } from '@angular/common/http';
import { Service } from '@angular/core';
import {Injectable, inject} from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class AccountService {
private http = inject(HttpClient);

baseUrl = 'https://localhost:5001/api/';

login(creds: any) {
  return this.http.post(this.baseUrl + 'account/login', creds);
}
}