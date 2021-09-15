import { Component, OnInit } from '@angular/core';

import { ApiService } from 'src/app/api.service';

import { DatePipe } from '@angular/common';

import { FormGroup, FormBuilder, Validators, FormControl, AsyncValidatorFn, AbstractControl } from '@angular/forms';


import { HttpClient, HttpClientModule } from '@angular/common/http';


@Component({
  selector: 'app-tabla-consulta',
  templateUrl: './tabla-consulta.component.html',
  styleUrls: ['./tabla-consulta.component.css'],
  providers: [DatePipe]
})
export class TablaConsultaComponent implements OnInit {

  constructor(private Apiservice:ApiService) {
    
  }
  public cliente: any;
  public alquiler: any;
  public carro: any;
  public pago: any;
  dataTable(){
    let algo;
    this.Apiservice.getcliente().subscribe(res=>{
      console.log(res);
      this.cliente  = res;
      algo = res;
    })
    this.Apiservice.getcarro().subscribe(res=>{
      this.carro= res;
      console.log(res);
    })
    this.Apiservice.getpago().subscribe(res=>{
      this.pago= res;
      console.log(res);
    })
    this.Apiservice.getalquiler().subscribe(res=>{
      this.alquiler = res;
      console.log(res);
    })
    
    
      
    
    
  }

  ngOnInit(): void {
    this.dataTable()
    
  }

}

interface cliente {
  CEDULA:Number;
    NOMBRE:String;
    TELEFONO1:Number;
    TELEFONO2:Number;
}
