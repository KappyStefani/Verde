<?php
include('cabecalho.php');
include('auxiliar/conectadb.php');
$sql = "SELECT * ,s_nome_categoria 
    FROM tb_produtos, tb_categorias 
    WHERE i_categoria_prod = i_id_categoria;"; //define a op no banco

$result = mysqli_query($link, $sql);

?>
<!DOCTYPE html>
<html lang="pt-br">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Minha Loja</title>
    <style>
        body {
            width: 80%;
            max-width: 800px;
            margin: 0 auto;
            font-family: 'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif;
            background-image: url('imagens/5891579.jpg');
            background-size: cover;
            /* para cobrir todo o fundo */
            background-repeat: repeat-y;
            /* para não repetir a imagem */
            background-attachment: fixed;
            /* para manter a imagem fixa enquanto a página rola */
        }

        div.product-container {
            width: 100%;
            height: 276px;
            background-color: #333;
            margin-top: 11px;
            display: flex;
            align-items: center;
            padding: 20px;
            box-sizing: border-box;
            border-radius: 8px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
            justify-content: space-around;
            flex-direction: row-reverse;
        }

        div.product-container img {
            height: 220px;
        }

        div.product-details {
            flex: 1;
            margin-left: 20px;
        }

        div.product-details h2 {
            color: #fff;
            margin: 0 0 10px;
        }

        div.product-details p {
            margin: 0;
            color: #888;
        }

        div.product-details span.price {
            font-size: 1.2em;
            font-weight: bold;
            color: #333;
            display: block;
            margin-top: 10px;
        }

        button {
            padding: 10px;
            background-color: #3498db;
            color: #fff;
            border: none;
            border-radius: 5px;
            cursor: pointer;
            font-size: 1em;
        }

        button:hover {
            background-color: #2980b9;
        }

        .img {
            width: 373px;
            text-align: center;
        }
    </style>
</head>

<body>
    <?php
    while ($tbl = mysqli_fetch_array($result)) {
    ?>
        <div class="product-container">
            <div class="img">
                <img src="imagens/<?= $tbl[8] ?>" alt="Product Image">
            </div>
            <div class="product-details">
                <h2><?= $tbl[1] ?></h2>
                <p><?= $tbl[2] ?></p>
                <p><?= $tbl[11] ?></p>
                <span class="price">R$ <?= number_format($tbl[5], 2, ",", ".") ?></span>
                <form action="carrinho.php" method="post">
                    <div id="btn">
                        <input type="hidden" name="operacao" value="adicionar">
                        <input type="number" name="quantidade" value="1" min="1" max="<?= $tbl[6] ?>" required step="1">
                        <input type="hidden" name="idproduto" value="<?= $tbl[0] ?>">
                        <button>+ Carrinho</button>
                    </div>
                </form>
            </div>
        </div>
    <?php
    }
    ?>

</body>

</html>