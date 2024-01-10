import styles from "./card.module.css";

export default function Card({ data }) {
  const { url, nome, preco } = data;

  return (
    <div
      className={`w-full max-w-sm bg-white border border-gray-200 rounded-lg shadow dark:bg-gray-800 dark:border-gray-700 ${styles.estilocard}`}
    >
      <a href="#">
        <img className="p-8 rounded-t-lg" src={url} alt="Imagem Destino" />
      </a>
      <div className="px-5 pb-5">
        <h5 className="text-xl font-semibold tracking-tight">{nome}</h5>
        <div className="flex items-center justify-between">
          <span className="text-3xl font-bold text-gray-900 dark:text-white">
            R$ {preco}
          </span>
          <a
            href="#"
            className={`focus:ring-4 focus:outline-none focus:ring-blue-300 font-medium rounded-lg text-sm px-5 py-2.5 text-center dark:bg-blue-600 dark:hover:bg-blue-700 dark:focus:ring-blue-800 ${styles.botaovisualizar}`}
          >
            Comprar
          </a>
        </div>
      </div>
    </div>
  );
}
