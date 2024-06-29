<?php
include('cabecalho.php');
include("auxiliar//conectadb.php");  // conecta o banco
$sql = "SELECT * FROM tb_usuario"; //define a op no banco

//faz a consulta e guarda o resultado na variavel $result
$result = mysqli_query($link, $sql);
?>
<!DOCTYPE html>
<html lang="pt-br">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Lista Usuários</title>
    <link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
    <link rel="stylesheet" href="auxiliar/estilo.css">
</head>

<body>
    <div class="divtabela">
        <table class="w3-table-all">
            <tr>
                <th>Nome</th>
                <th>Telefone</th>
                <th>Email</th>
                <th>Nível</th>


            </tr>
            <?php
            while ($tbl = mysqli_fetch_array($result))
            ?>
                <tr>
                    <td><?= $tbl[1] ?></td>
                    <td><?= $tbl[2] ?></td>
                    <td><?= $tbl[3] ?></td>
                    <td><?= $tbl[4] ?></td>
                    <td><?= $tbl[7] == 10 ? "Administrador" : "Cliente" ?></td>
                    
                    
                </tr>
        </table>
    </div>
</body>

</html>