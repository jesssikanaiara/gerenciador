import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  { path: '', redirectTo: 'estoque', pathMatch: 'full' },
  { path: 'estoque',  loadChildren: () => import('./estoque/estoque.module').then((m) => m.EstoqueModule)},
  { path: 'financeiro',  loadChildren: () => import('./financeiro/financeiro.module').then((m) => m.FinanceiroModule)}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
