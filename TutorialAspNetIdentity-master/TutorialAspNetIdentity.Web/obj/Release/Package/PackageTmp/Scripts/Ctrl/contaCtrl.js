angular.module("conta").controller("contaCtrl", function ($scope) {
    $scope.app = "Conta";

    $scope.started = true;
    $scope.started1 = true;
    $scope.texto = "acender lampada";
    $scope.texto1 = "ligar gás";


    $scope.txtPainel = "active";
    $scope.txtPag = "";
    $scope.txtDados = "";

    $scope.opDados = function()
    {
        $scope.txtPainel = "";
        $scope.txtPag = "";
        $scope.txtDados = "active";
        $scope.txtPartial = "";
    }
    $scope.opPag = function () {
        $scope.txtPainel = "";
        $scope.txtPag = "active";
        $scope.txtDados = "";
        $scope.txtPartial = "_Pagamento";
    }
    $scope.opPainel = function () {
        $scope.txtPainel = "active";
        $scope.txtPag = "";
        $scope.txtDados = "";
        $scope.txtPartial = "_Objetos";
    }

    $scope.start = function()
    {
       

        if ($scope.started == false) {
            $scope.started = true;
            $scope.texto = "acender lampada";
        }
        else
        {
            $scope.started = false;
            $scope.texto = "apagar lampada";
        }

    }
    $scope.start1 = function () {


        if ($scope.started1 == false) {
            $scope.started1 = true;
            $scope.texto1 = "ligar gás";
        }
        else {
            $scope.started1 = false;
            $scope.texto1 = "desligar gás";
        }

    }


    $scope.itens = [
        { nome: "Minha conta" },
        { nome: "Meus dados cadastrais" },
        { nome: "Minha casa" },
        { nome: "Pagamentos" },

    ];
    $scope.classe = "listSelecionado";
    $scope.isItemlistSelecionado = function (itens) {
        return itens.some(function (item) {
            return item.selecionado;
        });
    };
});