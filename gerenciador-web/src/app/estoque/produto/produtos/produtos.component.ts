import { Component, OnInit } from '@angular/core';
import { AbstractControl, Form, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { FiltroPaginacao } from 'src/app/modelos/filtro-paginacao.modelo';
import { NomeId } from 'src/app/modelos/nome-id.modelo';
import { Produto } from 'src/app/modelos/produto.modelo';
import { DominioService } from 'src/app/servicos/dominio.service';
import { ProdutoService } from 'src/app/servicos/produto.service';

@Component({
  selector: 'app-produtos',
  templateUrl: './produtos.component.html',
  styleUrls: ['./produtos.component.scss']
})
export class ProdutosComponent implements OnInit {
  categorias: Array<NomeId>;
  form: FormGroup;
  produtos: Array<Produto>;

  totalItens = 100;
  itensPorPagina = 10;
  paginaAtual = 0;
  paginaOpcoes: number[] = [5, 10, 25, 100];


  //colunas: string[] = ['codigoBarras', 'nome', 'valorCompra', 'valorVenda', 'categoriaNome'];
  colunas: string[] = ['codigoBarras', 'nome', 'valorVenda', 'acoes'];

  constructor(private dominioService: DominioService,
    private produtoService: ProdutoService,
    private builder: FormBuilder) {
  }

  ngOnInit(): void {
    this.carregarProdutos();
  }

  paginaAlterada(evento) {
    this.paginaAtual = evento.pageIndex;
    this.itensPorPagina = evento.pageSize;
    this.carregarProdutos();
  }

  carregarProdutos() {
    const param = new FiltroPaginacao();
    param.itensPorPagina = this.itensPorPagina;
    param.pagina = this.paginaAtual + 1;

    this.produtoService.filtrar('', param).subscribe(
      (produtos) => {
        this.produtos = produtos.lista;
        this.totalItens = produtos.totalItens;
      }
    );
  }
}



