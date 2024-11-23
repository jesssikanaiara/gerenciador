import { EnumTipoBandeiraCartao, EnumTipoFormaPagamento } from "./enumeradores";

export class VendaPagamento {
    numeroAutorizacao: string;
    valor: number;
    tipoPagamento: EnumTipoFormaPagamento;
    bandeiraCartao: EnumTipoBandeiraCartao;

    constructor( numeroAutorizacao: string,
                 valor: number,
                 tipoPagamento: EnumTipoFormaPagamento,
                 bandeiraCartao: EnumTipoBandeiraCartao){
        this.numeroAutorizacao = numeroAutorizacao;
        this.valor = valor;
        this.tipoPagamento = tipoPagamento;
        this.bandeiraCartao = bandeiraCartao;
    }
}
