import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { MatBottomSheet } from '@angular/material/bottom-sheet';
import { EnumTipoBandeiraCartao, EnumTipoFormaPagamento } from 'src/app/modelos/enumeradores';
import { VendaPagamento } from 'src/app/modelos/venda-pagamento.modelo';
import { ModalValorPagamentoComponent } from '../modal-valor-pagamento/modal-valor-pagamento.component';
import {MatSnackBar} from '@angular/material/snack-bar';
import { Action } from 'rxjs/internal/scheduler/Action';

@Component({
  selector: 'app-pagamento',
  templateUrl: './pagamento.component.html',
  styleUrls: ['./pagamento.component.scss']
})
export class PagamentoComponent implements OnInit {
  pagamentos: Array<VendaPagamento> = [];

  @Input()
  valorTotalVenda: number;

  valorPagamentos: number = 0;

  @Output() 
  pagamentoConcluido: EventEmitter<Array<VendaPagamento>> = new EventEmitter();

  constructor(private _bottomSheet: MatBottomSheet,
              private _snackBar: MatSnackBar) { }

  ngOnInit(): void {
  }

  async addPagamento(tipoPagamento: EnumTipoFormaPagamento, bandeira: EnumTipoBandeiraCartao) {
    const modal = this._bottomSheet.open(ModalValorPagamentoComponent);
    modal.instance.tipoPagamento = tipoPagamento;

    modal.afterDismissed().subscribe((result) => {
      if(!result.valor)
        return;

      if(result.valor > (this.valorTotalVenda - this.valorPagamentos)){
        this._snackBar.open('Valor do pagamento ultrapassa o valor restante da venda', 'Fechar');
        return;
      }

      if(result.valor){
        this.pagamentos.push(new VendaPagamento(result.codigoTransacao, result.valor, tipoPagamento, bandeira));        
        this.valorPagamentos += result.valor;
        this.verificarStatusPagamento();
      }
    });    
  }  

  verificarStatusPagamento(){
    if(this.valorPagamentos == this.valorTotalVenda){      
      this.pagamentoConcluido.emit(this.pagamentos);
    }
  }
}
