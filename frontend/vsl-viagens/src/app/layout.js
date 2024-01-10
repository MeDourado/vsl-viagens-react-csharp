import { Nunito_Sans } from "next/font/google";
import "./globals.css";
import Footer from "./components/Footer";
import Header from "./components/Header";

const nunitoSans = Nunito_Sans({ subsets: ["latin"] });

export const metadata = {
  title: "VSL VIAGENS",
  description: "Pagina inicial da agencia de viagens - VSL VIAGENS ",
};

export default function RootLayout({ children }) {
  return (
    <html lang="pt-br">
      <body className={nunitoSans.className}>
        <Header />
        {children}
        <Footer />
      </body>
    </html>
  );
}
