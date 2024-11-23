import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ClienteNovoComponent } from './cliente/cliente-novo/cliente-novo.component';
import { ClientesComponent } from './cliente/clientes/clientes.component';
import { PdvComponent } from './pdv/pdv.component'; 

const routes: Routes = [  
  {
    path: 'clientes',
    component: ClientesComponent
  },
  {
    path: 'clientes/novo',
    component: ClienteNovoComponent
  },
  {
    path: 'pdv',
    component: PdvComponent
  }  
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class FinanceiroRoutingModule { }
