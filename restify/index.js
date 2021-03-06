var restify = require('restify');

function respond(req, res, next) {
  res.send('hello restify');
  next();
}

var server = restify.createServer();
server.get('/', respond);

server.listen(1000, function() {
  console.log('%s listening at %s', server.name, server.url);
});