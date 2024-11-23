import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { FinanceiroRoutingModule } from './financeiro-routing.module';
import { ClientesComponent } from './cliente/clientes/clientes.component';
import { ClienteNovoComponent } from './cliente/cliente-novo/cliente-novo.component';
import { CompartilhadoModule } from '../compartilhado/compartilhado.module';
import { PdvComponent } from './pdv/pdv.component';


@NgModule({
  declarations: [
    ClientesComponent,
    ClienteNovoComponent,
    PdvComponent
  ],
  imports: [
    CommonModule,
    FinanceiroRoutingModule,
    CompartilhadoModule
  ]
})
export class FinanceiroModule { }
