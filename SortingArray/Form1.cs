using System;
using System.Collections;
using System.Windows.Forms;

namespace SortingArray
{
    public partial class frmSortingArray : Form
    {
        public frmSortingArray()
        {
            InitializeComponent();
        }

        public void btnSortingArray_Click(object sender, EventArgs e)
        {
            ArrayList _ARRL = Arr_new();
            void_sorting(_ARRL);
        }
        public void btnSortingArrayBad_Click(object sender, EventArgs e)
        {
            ArrayList _ARRL = Arr_new_bad();
            void_sorting(_ARRL);
        }

        private static void void_sorting(ArrayList _ARRL)
        {
            string _smess = "Карточки перепутаны, собираемся в дорогу: ";
            int _i_s = _ARRL.Count;
            foreach (string _s_t in _ARRL)
            {
                _smess = string.Format("{0}{1}{2}", _smess, Environment.NewLine, _s_t);
            }
            MessageBox.Show(_smess, "Исходные данные", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ArrayList _new_AL = SortArrL(_ARRL, true);
            int _i_e = _new_AL.Count;
            MessageBoxIcon _mi = MessageBoxIcon.Information;
            if (_i_s != _i_e)
            {
                _mi = MessageBoxIcon.Error;
                _smess = string.Format("При обработке карточек произошла ошибка.{0}Необходимо пересмотреть маршрут путешествия.", Environment.NewLine);
            }
            else
            {
                _smess = "Путешествие по городам Европы:";
                foreach (string _s_t in _new_AL)
                {
                    _smess = string.Format("{0}{1}{2}", _smess, Environment.NewLine, _s_t);
                }
            }
            MessageBox.Show(_smess, "Результат обработки", MessageBoxButtons.OK, _mi);
            
        }
        public static ArrayList Arr_new()
        {
            ArrayList _aReturn = new ArrayList
                                  {
                                      "Мельбурн > Кельн",
                                      "Варшава > Мельбурн",
                                      "Москва > Париж",
                                      "Кельн > Москва",
                                      "Берлин > Варшава",
                                      "Париж > Берлин"
                                  };
            return _aReturn;
        }
        public static ArrayList Arr_new_bad()
        {
            ArrayList _aReturn = new ArrayList
                                  {
                                      "Мельбурн > Кельн",
                                      "Варшава > Мельбурн",
                                      "Москва > Парижж",
                                      "Кельн > Москва",
                                      "Берлин > Варшава",
                                      "Париж > Берлин"
                                  };
            return _aReturn;
        }

        public static ArrayList SortArrL(ArrayList _aL, bool _bMess)
        {
            ArrayList _aReturn = new ArrayList();
            try
            {
                string _sL = _aL[0].ToString();
                _aReturn.Add(_sL); // Первый элемент добавили
                _aL.RemoveAt(0); // Пенрвый элемент удалили

                int _i = _aL.Count;
                string _ss_e = _sL.Substring(_sL.IndexOf(">") + 2, _sL.Length - _sL.IndexOf(">") - 2); // Пункт отправления
                for (int ii = 0; ii <= _i - 1; ii++)
                {
                    int iT = 0;
                    bool _b = false;
                    foreach (string _s_t in _aL)
                    {
                        string _ts_s = _s_t.Substring(0, _s_t.IndexOf(">") - 1); // Прибытие
                        string _ts_e = _s_t.Substring(_s_t.IndexOf(">") + 2, _s_t.Length - _s_t.IndexOf(">") - 2); // Отправление
                        if (_ts_s.Contains(_ss_e)) // Прибытие = Отправление
                        {
                            _aReturn.Add(_s_t);
                            _ss_e = _ts_e;
                            _aL.RemoveAt(iT);
                            _b = true;
                            break;
                        }
                        iT++;
                    }
                    if (!_b && _bMess) // Пункт прибытия не найден
                    {
                        MessageBox.Show(string.Format("Для карточки с пунктом отправления \"{0}\" не найдена карточка с соответствующим пунктом прибытия.{1}Что-то пошло не так.", _ss_e, Environment.NewLine), "Результат обработки", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Обработка ошибки классом Logger");
            }
            return _aReturn;
        }
    }
}
