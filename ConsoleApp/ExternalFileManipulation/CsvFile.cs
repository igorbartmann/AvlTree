using System;
using System.IO;

namespace ConsoleApp.ExternalFileManipulation
{
    /// <summary>
    /// Classe para ler e gravar texto CSV em arquivos externos.
    /// </summary>
    public class CsvFile
    {
        #region Constantes
        private const string DEFAULT_FILE_NAME = "AvlTreeDataFile";
        private const string DEFAULT_FILE_EXTENSION = ".txt";
        #endregion

        #region Atributes

        public string FilePath { get; private set; }
        public string FileName { get; private set; }
        public string FileExtension { get; private set; }
        public string FileCompleteReference => FilePath + FileName + FileExtension;

        public bool IsWindowsForm { get; set; }
        private bool FileNotFound { get; set; }

        #endregion

        /// <summary>
        /// Construtor da classe.
        /// </summary>
        public CsvFile(bool isWindowsForm = true)
        {
            this.IsWindowsForm = isWindowsForm;        
        }

        /// <summary>
        /// Construtor da classe.
        /// </summary>
        public CsvFile(string fileName, string fileExtension, string filePath = null, bool isWindowsForm = true)
        {
            this.FileName = ValidateFileName(fileName);
            this.FileExtension = ValidateFormatExtension(fileExtension);
            this.FilePath = ValidateFormatPath(filePath);
            this.IsWindowsForm = isWindowsForm;
        }

        #region Métodos de encapsulamento (setters)

        /// <summary>
        /// Alterar o caminho para o arquivo.
        /// </summary>
        /// <param name="filePath">Novo caminho para o arquivo.</param>
        public void SetFilePath(string filePath)
        {
            this.FilePath = ValidateFormatPath(filePath);
        }

        /// <summary>
        /// Alterar o nome do arquivo.
        /// </summary>
        /// <param name="fileName">Novo nome do arquivo</param>
        public void SetFileName(string fileName)
        {
            this.FileName = ValidateFileName(fileName);
        }

        /// <summary>
        /// Alterar a extensão do arquivo.
        /// </summary>
        /// <param name="fileExtension">Nova extensão do arquivo</param>
        public void SetFileExtension(string fileExtension)
        {
            this.FileExtension = ValidateFormatExtension(fileExtension);
        }

        #endregion

        #region Métodos necessários para ler e gravar no arquivo

        /// <summary>
        /// Ler a partir do arquivo.
        /// </summary>
        /// <returns>(string, bool)<br/>
        /// Caso true, string é o conteúdo lido.<br/>
        /// Caso false, string é a mensagem de erro.</returns>
        public (string, bool) Reader()
        {
            try
            {
                if (!File.Exists(FileCompleteReference) || this.FileNotFound)
                {
                    this.FileNotFound = true;
                    throw new FileNotFoundException();
                }

                Stream file = File.Open(FileCompleteReference, FileMode.Open);
                StreamReader streamReader = new StreamReader(file);

                string content = streamReader.ReadToEnd();

                streamReader.Close();
                file.Close();

                return (content, true);
            }
            catch(FileNotFoundException)
            {
                return ("O arquivo não foi encontrado!", false);
            }
            catch (IOException)
            {
                return ($"Ocorreu um erro para realizar a leitura do arquivo \"{FileCompleteReference}\".", false);
            }
            catch(Exception)
            {
                return ($"Algo inesperado ocorreu, contate o administrador do sistema!", false);
            }
        }

        /// <summary>
        /// Gravar no arquivo.
        /// </summary>
        /// <returns>Mensagem de erro ou string vazia, para o caso de não ocorrerem erros.</returns>
        public string Writer(string content, int totDataPerRow)
        {
            try
            {
                if (this.FileNotFound)
                {
                    if (string.IsNullOrWhiteSpace(content))
                    {
                        throw new FileNotFoundException();
                    }

                    this.FileExtension = DEFAULT_FILE_EXTENSION;
                }

                Stream file = File.Open(FileCompleteReference, FileMode.Create);
                StreamWriter streamWriter = new StreamWriter(file);

                if (string.IsNullOrWhiteSpace(content))
                {
                    streamWriter.WriteLine(); // Para limpar o conteúdo atual do arquivo
                }
                else
                {
                    string[] contentSplit = content.Split(';');
                    for (int count = 0; count < contentSplit.Length - 1; count++)
                    {
                        streamWriter.Write(contentSplit[count] + ";");
                        if ((count + 1) % totDataPerRow == 0)
                        {
                            streamWriter.WriteLine();
                        }
                    }
                }                

                streamWriter.Close();
                file.Close();

                return null;
            }
            catch (FileNotFoundException)
            {
                return ($"O Arquivo não foi ser encontrado!");
            }
            catch (IOException)
            {
                return $"Ocorreu um erro para gravar os dados no arquivo \"{FileCompleteReference}\".";
            }
            catch (Exception)
            {
                return $"Algo inesperado ocorreu, contate o desenvolvedor!";
            }
        }

        #endregion

        #region Métodos auxiliáres

        public bool ValideFileExist()
        {
            return File.Exists(FileCompleteReference);
        }

        /// <summary>
        /// Formatar o path do arquivo.
        /// </summary>
        /// <param name="path">Path do arquivo a ser lido</param>
        /// <returns>Path no formato correto</returns>
        private string ValidateFormatPath(string path)
        {
            if(path == null)
            {
                path = string.Empty;
            }
            else if(path != string.Empty
                && (path.Substring(path.Length - 1) != "/"
                    || path.Substring(path.Length - 1) != "\\"))
            {
               path += "/";
            }

            return path.Replace('\\', '/');
        }

        /// <summary>
        /// Validar o formato do nome do arquivo.
        /// </summary>
        /// /// <param name="name">Nome do arquivo a ser lido</param>
        /// <returns>Nome no formato correto</returns>
        private string ValidateFileName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                this.FileNotFound = true;
                return DEFAULT_FILE_NAME;
            }

            return name;
        }

        /// <summary>
        /// Validar o formato da extansão do arquivo.
        /// </summary>
        /// /// <param name="extension">Extensão do arquivo a ser lido</param>
        /// <returns>Extensão no formato correto</returns>
        private string ValidateFormatExtension(string extension)
        {
            if(!IsWindowsForm && (extension == null || extension.Length < 2))
            {
                return ".txt";
            }
            if (!extension.StartsWith("."))
            {
                return "." + extension;
            }
            return extension;
        }

        #endregion
    }
}