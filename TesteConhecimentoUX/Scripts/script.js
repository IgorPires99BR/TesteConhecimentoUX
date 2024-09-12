function formataTelefone() {
        $('#Telefone').on('input', function () {
            var telefone = $(this).val();

            telefone = telefone.replace(/\D/g, '');

            if (telefone.length <= 10) {
                telefone = telefone.replace(/^(\d{2})(\d{4})(\d{0,4})$/, '($1) $2-$3');
            } else {
                telefone = telefone.replace(/^(\d{2})(\d{5})(\d{0,4})$/, '($1) $2-$3');
            }

            $(this).val(telefone);

        })
}

function formataNome() {
    $('#Nome').on('input', function () {
        var Nome = $(this).val();

        Nome = Nome.replace(/\d/g, '');

        $(this).val(Nome);

    })
}