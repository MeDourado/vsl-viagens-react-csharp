import styles from "./page.module.css";
import Intro_Section from "./components/Intro_Section";
import Lista_Destinos from "./components/Lista_Destinos";
import Faq from "./components/Faq";

export default function Home() {
  const faqData = [
    {
      question: "Como faço para reservar passagens?",
      answer:
        "Você pode reservar passagens diretamente em nosso site ou entrar em contato conosco para assistência personalizada.",
    },
    {
      question: "Quais são os destinos disponíveis?",
      answer:
        "Oferecemos uma ampla variedade de destinos nacionais e internacionais. Consulte nosso site para ver a lista completa.",
    },
    {
      question: "Posso cancelar minha reserva?",
      answer:
        "Sim, é possível cancelar sua reserva. Entre em contato conosco o mais rápido possível para mais detalhes sobre as políticas de cancelamento.",
    },
    {
      question: "Quais são as opções de pagamento?",
      answer:
        "Aceitamos várias formas de pagamento, incluindo cartões de crédito, transferência bancária e pagamento online.",
    },
  ];

  return (
    <main className={styles.main}>
      <Intro_Section />
      <h2 className={styles.titulo_sessao} id="destinos">
        {" "}
        DESTINOS{" "}
      </h2>
      <Lista_Destinos />
      <h2 className={styles.titulo_sessao} id="faq">
        {" "}
        PERGUNTAS FREQUENTES{" "}
      </h2>
      <Faq faqData={faqData} />
    </main>
  );
}
