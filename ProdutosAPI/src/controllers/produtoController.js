
let prodList = { items: [] }
let lista = prodList.items;

exports.get = (req, res, next) => {
    res.end('Lista de produtos recuperado com sucesso!');
};

exports.getById = (req, res, next) => {
    res.end('Produto ' +  req.params.id.toString() + ' recuperado com sucesso!');
};

exports.post = (req, res, next) => {
    res.end('Produto adicionado com sucesso!');
};

exports.put = (req, res, next) => {
    res.end('Produto ' +  req.params.id.toString() + ' atualizado com sucesso!');
};

exports.delete = (req, res, next) => {
    res.end('Produto ' +  req.params.id.toString() + ' deletado com sucesso!');
};