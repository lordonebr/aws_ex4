
let prodList = { items: [] }
let lista = prodList.items;

exports.get = (req, res, next) => {
    res.end('Lista de produtos do carrinho recuperado com sucesso!');
};

exports.getById = (req, res, next) => {
    res.end('Produto ' +  req.params.id.toString() + ' recuperado do carrinho com sucesso!');
};

exports.post = (req, res, next) => {
    res.end('Produto adicionado no carrinho com sucesso!');
};

exports.put = (req, res, next) => {
    res.end('Produto ' +  req.params.id.toString() + ' atualizado no carrinho com sucesso!');
};

exports.delete = (req, res, next) => {
    res.end('Produto ' +  req.params.id.toString() + ' removido do carrinho com sucesso!');
};