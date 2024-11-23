import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ProdutoNovoComponent } from './produto/produto-novo/produto-novo.component';
import { ProdutosComponent } from './produto/produtos/produtos.component';

const routes: Routes = [
  { path: '', redirectTo: 'produtos' },
  {
    path: 'produtos',
    component: ProdutosComponent,    
  },
  {
    path: 'produtos/novo',
    component: ProdutoNovoComponent
  },
  {
    path: 'produtos/atualizar/:id',
    component: ProdutoNovoComponent
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class EstoqueRoutingModule { }
