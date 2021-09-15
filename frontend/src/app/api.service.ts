import { Injectable } from '@angular/core';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { Observable } from 'rxjs';
import { carro } from './carro';
import { cliente } from './cliente';
import { alquiler } from './alquiler';
import { pagos } from './pagos';



@Injectable({
  providedIn: 'root'
})
export class ApiService {
  

  // API nodejs y postgresql
  API: string = "http://localhost:5000/api/"

  constructor(private clientHttp: HttpClient) { }

  
  getcliente() {
    return this.clientHttp.get(this.API + "clientes")
  }

  getcarro() {
    return this.clientHttp.get(this.API + "carroes")
  }

  getalquiler() {
    return this.clientHttp.get(this.API + "alquilers")
  }

  getpago() {
    return this.clientHttp.get(this.API + "pagos")
  }

}
