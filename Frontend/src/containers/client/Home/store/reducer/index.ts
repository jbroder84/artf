import {AnyAction} from "redux";
import {DEFAULT_HOME_PAGE_STATE, IHomePageState, DEFAULT_CONTACTS} from "../state";
import {getType} from "typesafe-actions";
import {genericRequestReducer, DEFAULT_REQUEST_STATE} from "../../../../../api";
import {
  actionIsActivePopup,
  actionFetchInfoCard,
  actionFetchInfoCardSuccess,
  actionFetchInfoCardlFailUrl,
  actionFetchInfoContacts,
  actionFetchInfoContactsSuccess,
  actionFetchInfoContactsFailUrl,
  actionClearInfoContacts,
} from "../actions";

const fetchSaveInfoCardStateReducer = genericRequestReducer(
  actionFetchInfoCard,
  actionFetchInfoCardSuccess,
  actionFetchInfoCardlFailUrl
)

const fetchInfoContactsStateReducer = genericRequestReducer(
  actionFetchInfoContacts,
  actionFetchInfoContactsSuccess,
  actionFetchInfoContactsFailUrl
)

export const homePageReducer = (state: IHomePageState = DEFAULT_HOME_PAGE_STATE, action: AnyAction): IHomePageState => {
  switch (action.type) {
    case getType(actionFetchInfoCard):
      return {
        ...state,
        infoCardState: fetchSaveInfoCardStateReducer(state.infoCardState, action)
      };
    case getType(actionFetchInfoCardSuccess):
      return {
        ...state,
        infoCardState: fetchSaveInfoCardStateReducer(state.infoCardState, action),
        infoCard: action.payload.data
      };
    case getType(actionFetchInfoCardlFailUrl):
      return {
        ...state,
        infoCardState: fetchSaveInfoCardStateReducer(state.infoCardState, action),
      };
    case getType(actionIsActivePopup):
      return {
        ...state,
        isActivePopup: action.payload.data
      };
    case getType(actionFetchInfoCard):
      return {
        ...state,
        infoCardState: fetchSaveInfoCardStateReducer(state.infoCardState, action)
      };
    case getType(actionFetchInfoCardSuccess):
      return {
        ...state,
        infoCardState: fetchSaveInfoCardStateReducer(state.infoCardState, action),
        infoCard: action.payload.data
      };
    case getType(actionFetchInfoCardlFailUrl):
      return {
        ...state,
        infoCardState: fetchSaveInfoCardStateReducer(state.infoCardState, action),
      };
    case getType(actionFetchInfoContacts): {
      return {
        ...state,
        infoContactsState: fetchInfoContactsStateReducer(state.infoContactsState, action)
      }
    }
    case getType(actionFetchInfoContactsSuccess):
      return {
        ...state,
        infoContactsState: fetchInfoContactsStateReducer(state.infoContactsState, action),
        infoContacts: action.payload
      };
    case getType(actionFetchInfoContactsFailUrl):
      return {
        ...state,
        infoContactsState: fetchInfoContactsStateReducer(state.infoContactsState, action)
      };
    case getType(actionClearInfoContacts): {
      return {
        ...state,
        infoContacts: { ...DEFAULT_CONTACTS },
        infoContactsState: { ...DEFAULT_REQUEST_STATE },
      }
    }
    default:
        return state;
  }
};

export const HOME_PAGE_KEY = 'homePage';