import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { MatBottomSheetRef } from '@angular/material/bottom-sheet';
import { MatSnackBar } from '@angular/material/snack-bar';
import { EnumTipoFormaPagamento } from 'src/app/modelos/enumeradores';

@Component({
  selector: 'app-modal-valor-pagamento',
  templateUrl: './modal-valor-pagamento.component.html',
  styleUrls: ['./modal-valor-pagamento.component.scss']
})
export class ModalValorPagamentoComponent implements OnInit {
  tipoPagamento: EnumTipoFormaPagamento;
  
  @ViewChild("txtvalor") txtValor: ElementRef;
  valor: number = null;

  codigoTransacao: string;

  constructor(private _bottomSheetRef: MatBottomSheetRef<ModalValorPagamentoComponent>,
              private _snackBar: MatSnackBar) { }

  get exibirCampoCodigo(): boolean{
    return this.tipoPagamento == EnumTipoFormaPagamento.CartaoCredito || this.tipoPagamento == EnumTipoFormaPagamento.CartaoDebito;
  }

  ngOnInit(): void {
    setTimeout(() => {
      this.txtValor.nativeElement.focus();      
      this.txtValor.nativeElement.select();      
    }, 200);
  }
  
  enviar(){
    if(this.exibirCampoCodigo && !this.codigoTransacao){
      this._snackBar.open('Favor informar o código da transação', 'Fechar');
      return;
    }

    if(this.valor > 0){
      this._bottomSheetRef.dismiss({valor: this.valor, codigoTransacao: this.codigoTransacao});
    }
  }
}
