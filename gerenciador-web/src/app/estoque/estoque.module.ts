import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { EstoqueRoutingModule } from './estoque-routing.module';
import { ProdutosComponent } from './produto/produtos/produtos.component';
import { CompartilhadoModule } from '../compartilhado/compartilhado.module';
import { ProdutoNovoComponent } from './produto/produto-novo/produto-novo.component';


@NgModule({
  declarations: [
    ProdutosComponent,
    ProdutoNovoComponent
  ],
  imports: [
    CommonModule,
    EstoqueRoutingModule,
    CompartilhadoModule 
  ]
})
export class EstoqueModule { }
