import { Component, OnInit } from '@angular/core';
import { FiltroPaginacao } from 'src/app/modelos/filtro-paginacao.modelo';
import { Produto } from 'src/app/modelos/produto.modelo';
import { ProdutoService } from 'src/app/servicos/produto.service';
import { MatBottomSheet, MatBottomSheetRef } from '@angular/material/bottom-sheet';
import { ModalQuantidadeProdutoComponent } from 'src/app/compartilhado/modal-quantidade-produto/modal-quantidade-produto.component';
import { ProdutoVenda } from 'src/app/modelos/produto-venda.modelo';
import { VendaPagamento } from 'src/app/modelos/venda-pagamento.modelo';
import { VendaService } from 'src/app/servicos/venda.service';
import { MatSnackBar } from '@angular/material/snack-bar';

@Component({
  selector: 'app-pdv',
  templateUrl: './pdv.component.html',
  styleUrls: ['./pdv.component.scss']
})
export class PdvComponent implements OnInit {
  produtos: Array<Produto>;
  produtosVenda: Array<ProdutoVenda> = [];
  fasePagamentos: boolean = false;
  processandoVenda: boolean = false;
  abrirResumoMobile: boolean = false;

  public get totalVenda(): number {
    if (this.produtosVenda.length)
      return this.produtosVenda.map(x => x.total).reduce((a, b) => a + b);
    else
      return 0;
  }

  constructor(private produtoService: ProdutoService,
    private _bottomSheet: MatBottomSheet,
    private vendaService: VendaService,
    private snackBar: MatSnackBar) { }

  ngOnInit(): void {
    this.carregarProdutos();
  }

  carregarProdutos() {
    const param = new FiltroPaginacao();
    param.itensPorPagina = 200;
    param.pagina = 1;

    this.produtoService.filtrar('', param).subscribe(
      (produtos) => {
        this.produtos = produtos.lista;
      }
    );
  }

  async addProduto(produto: Produto) {
    const modal = this._bottomSheet.open(ModalQuantidadeProdutoComponent);
    modal.afterDismissed().subscribe((quantidade) => {
      if(quantidade > 0){
        this.produtosVenda.push(new ProdutoVenda(produto, quantidade));        
      }
    });
  }

  pagamentoConcluido(pagamentos: Array<VendaPagamento>) {
    this.fasePagamentos = false;
    const venda = {
      produtos: this.produtosVenda.map(x => { return { idProduto: x.produto.id, quantidade: x.quantidade } }),
      pagamentos: pagamentos
    }

    this.processandoVenda = true;
    this.vendaService.post(venda).subscribe(
      (r) => {
        this.processandoVenda = false;        
        this.limparVenda();
        this.abrirResumoMobile = false;
        this.snackBar.open('Venda processada com sucesso', 'Ok');
      },
      (erro)=>{
        this.snackBar.open(erro, 'Ok');
      }
    );
  }

  limparVenda(){
    this.produtosVenda = [];
  }

  finalizarVendas() {
    this.fasePagamentos = true;
  }
}
