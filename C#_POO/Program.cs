Album albumDoqueen = new Album();
albumDoqueen.Nome = "A night at the opera";

Musica musica1 = new Musica();
musica1.Nome = "Love of my life";
musica1.Duracao = 213;

Musica musica2 = new Musica();
musica2.Nome = "Bohemian Rhapsody";
musica2.Duracao = 354;

albumDoqueen.AdicionarMusica(musica1);
albumDoqueen.AdicionarMusica(musica2);

albumDoqueen.ExibirMusicasDoAlbum();